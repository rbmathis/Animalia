using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Greenwoodochromis;

/// <summary>
/// Abstract class for Greenwoodochromis (genus).
/// NCBI TaxId: 286575
/// </summary>
public abstract class Greenwoodochromis : Cichlidae, IGreenwoodochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Greenwoodochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286575;

    /// <inheritdoc />
    public virtual string GenusName => "Greenwoodochromis";

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
