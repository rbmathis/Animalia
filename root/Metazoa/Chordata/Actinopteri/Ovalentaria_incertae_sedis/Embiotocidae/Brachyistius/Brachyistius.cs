using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Brachyistius;

/// <summary>
/// Abstract class for Brachyistius (genus).
/// NCBI TaxId: 100187
/// </summary>
public abstract class Brachyistius : Embiotocidae, IBrachyistius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyistius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100187;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyistius";

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
