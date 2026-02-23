using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Climacteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Climacteridae.Cormobates;

/// <summary>
/// Abstract class for Cormobates (genus).
/// NCBI TaxId: 181834
/// </summary>
public abstract class Cormobates : Climacteridae, ICormobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cormobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181834;

    /// <inheritdoc />
    public virtual string GenusName => "Cormobates";

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
