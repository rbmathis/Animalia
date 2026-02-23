using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Pristobrycon;

/// <summary>
/// Abstract class for Pristobrycon (genus).
/// NCBI TaxId: 42534
/// </summary>
public abstract class Pristobrycon : Serrasalmidae, IPristobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pristobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42534;

    /// <inheritdoc />
    public virtual string GenusName => "Pristobrycon";

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
