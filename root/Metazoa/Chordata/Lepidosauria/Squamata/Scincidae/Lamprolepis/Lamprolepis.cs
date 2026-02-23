using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lamprolepis;

/// <summary>
/// Abstract class for Lamprolepis (genus).
/// NCBI TaxId: 96744
/// </summary>
public abstract class Lamprolepis : Scincidae, ILamprolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lamprolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96744;

    /// <inheritdoc />
    public virtual string GenusName => "Lamprolepis";

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
