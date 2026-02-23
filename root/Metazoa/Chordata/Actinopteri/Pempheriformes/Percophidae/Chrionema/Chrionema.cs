using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.Chrionema;

/// <summary>
/// Abstract class for Chrionema (genus).
/// NCBI TaxId: 1585637
/// </summary>
public abstract class Chrionema : Percophidae, IChrionema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrionema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1585637;

    /// <inheritdoc />
    public virtual string GenusName => "Chrionema";

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
