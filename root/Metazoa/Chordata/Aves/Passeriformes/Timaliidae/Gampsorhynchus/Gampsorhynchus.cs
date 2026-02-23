using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Gampsorhynchus;

/// <summary>
/// Abstract class for Gampsorhynchus (genus).
/// NCBI TaxId: 201307
/// </summary>
public abstract class Gampsorhynchus : Timaliidae, IGampsorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gampsorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201307;

    /// <inheritdoc />
    public virtual string GenusName => "Gampsorhynchus";

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
