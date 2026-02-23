using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Drepanorhynchus;

/// <summary>
/// Abstract class for Drepanorhynchus (genus).
/// NCBI TaxId: 1491773
/// </summary>
public abstract class Drepanorhynchus : Nectariniidae, IDrepanorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drepanorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1491773;

    /// <inheritdoc />
    public virtual string GenusName => "Drepanorhynchus";

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
