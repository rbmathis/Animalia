using AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae.Ephippiorhynchus;

/// <summary>
/// Abstract class for Ephippiorhynchus (genus).
/// NCBI TaxId: 52782
/// </summary>
public abstract class Ephippiorhynchus : Ciconiidae, IEphippiorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ephippiorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52782;

    /// <inheritdoc />
    public virtual string GenusName => "Ephippiorhynchus";

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
