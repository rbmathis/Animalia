using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Pseudoleptodeira;

/// <summary>
/// Abstract class for Pseudoleptodeira (genus).
/// NCBI TaxId: 427733
/// </summary>
public abstract class Pseudoleptodeira : Dipsadidae, IPseudoleptodeira
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoleptodeira";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 427733;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoleptodeira";

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
