using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cyanolyca;

/// <summary>
/// Abstract class for Cyanolyca (genus).
/// NCBI TaxId: 54576
/// </summary>
public abstract class Cyanolyca : Corvidae, ICyanolyca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanolyca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54576;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanolyca";

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
