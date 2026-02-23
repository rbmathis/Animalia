using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylvia;

/// <summary>
/// Abstract class for Sylvia (genus).
/// NCBI TaxId: 43162
/// </summary>
public abstract class Sylvia : Sylviidae, ISylvia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sylvia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43162;

    /// <inheritdoc />
    public virtual string GenusName => "Sylvia";

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
