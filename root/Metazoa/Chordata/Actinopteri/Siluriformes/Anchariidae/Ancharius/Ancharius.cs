using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Anchariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Anchariidae.Ancharius;

/// <summary>
/// Abstract class for Ancharius (genus).
/// NCBI TaxId: 3362148
/// </summary>
public abstract class Ancharius : Anchariidae, IAncharius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ancharius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362148;

    /// <inheritdoc />
    public virtual string GenusName => "Ancharius";

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
