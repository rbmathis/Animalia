using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cribroheros;

/// <summary>
/// Abstract class for Cribroheros (genus).
/// NCBI TaxId: 1830338
/// </summary>
public abstract class Cribroheros : Cichlidae, ICribroheros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cribroheros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1830338;

    /// <inheritdoc />
    public virtual string GenusName => "Cribroheros";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
