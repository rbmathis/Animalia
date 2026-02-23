using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Cyclopteropsis;

/// <summary>
/// Abstract class for Cyclopteropsis (genus).
/// NCBI TaxId: 1302284
/// </summary>
public abstract class Cyclopteropsis : Cyclopteridae, ICyclopteropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclopteropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1302284;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclopteropsis";

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
