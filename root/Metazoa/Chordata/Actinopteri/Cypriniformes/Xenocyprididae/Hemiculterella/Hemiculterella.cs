using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Hemiculterella;

/// <summary>
/// Abstract class for Hemiculterella (genus).
/// NCBI TaxId: 432386
/// </summary>
public abstract class Hemiculterella : Xenocyprididae, IHemiculterella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiculterella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432386;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiculterella";

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
