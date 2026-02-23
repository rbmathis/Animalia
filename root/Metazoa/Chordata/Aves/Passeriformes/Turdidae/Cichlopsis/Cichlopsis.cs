using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Cichlopsis;

/// <summary>
/// Abstract class for Cichlopsis (genus).
/// NCBI TaxId: 164898
/// </summary>
public abstract class Cichlopsis : Turdidae, ICichlopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cichlopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164898;

    /// <inheritdoc />
    public virtual string GenusName => "Cichlopsis";

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
