using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae.Pachysylvia;

/// <summary>
/// Abstract class for Pachysylvia (genus).
/// NCBI TaxId: 3150868
/// </summary>
public abstract class Pachysylvia : Vireonidae, IPachysylvia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachysylvia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150868;

    /// <inheritdoc />
    public virtual string GenusName => "Pachysylvia";

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
