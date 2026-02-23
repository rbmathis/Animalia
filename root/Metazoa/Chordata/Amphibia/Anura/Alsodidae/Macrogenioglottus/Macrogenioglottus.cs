using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Macrogenioglottus;

/// <summary>
/// Abstract class for Macrogenioglottus (genus).
/// NCBI TaxId: 635161
/// </summary>
public abstract class Macrogenioglottus : Alsodidae, IMacrogenioglottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrogenioglottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 635161;

    /// <inheritdoc />
    public virtual string GenusName => "Macrogenioglottus";

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
