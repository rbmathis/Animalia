using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Dierogekko;

/// <summary>
/// Abstract class for Dierogekko (genus).
/// NCBI TaxId: 1096129
/// </summary>
public abstract class Dierogekko : Diplodactylidae, IDierogekko
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dierogekko";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1096129;

    /// <inheritdoc />
    public virtual string GenusName => "Dierogekko";

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
