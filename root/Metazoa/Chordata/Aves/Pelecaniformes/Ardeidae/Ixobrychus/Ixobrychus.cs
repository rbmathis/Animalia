using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Ixobrychus;

/// <summary>
/// Abstract class for Ixobrychus (genus).
/// NCBI TaxId: 110684
/// </summary>
public abstract class Ixobrychus : Ardeidae, IIxobrychus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ixobrychus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 110684;

    /// <inheritdoc />
    public virtual string GenusName => "Ixobrychus";

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
