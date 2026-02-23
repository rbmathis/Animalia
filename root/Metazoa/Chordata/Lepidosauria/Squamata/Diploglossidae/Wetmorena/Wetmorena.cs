using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Wetmorena;

/// <summary>
/// Abstract class for Wetmorena (genus).
/// NCBI TaxId: 2839126
/// </summary>
public abstract class Wetmorena : Diploglossidae, IWetmorena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wetmorena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2839126;

    /// <inheritdoc />
    public virtual string GenusName => "Wetmorena";

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
