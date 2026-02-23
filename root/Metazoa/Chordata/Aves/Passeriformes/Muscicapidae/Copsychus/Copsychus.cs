using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Copsychus;

/// <summary>
/// Abstract class for Copsychus (genus).
/// NCBI TaxId: 125862
/// </summary>
public abstract class Copsychus : Muscicapidae, ICopsychus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Copsychus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125862;

    /// <inheritdoc />
    public virtual string GenusName => "Copsychus";

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
