using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Homopus;

/// <summary>
/// Abstract class for Homopus (genus).
/// NCBI TaxId: 285991
/// </summary>
public abstract class Homopus : Testudinidae, IHomopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Homopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 285991;

    /// <inheritdoc />
    public virtual string GenusName => "Homopus";

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
