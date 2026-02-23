using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Arses;

/// <summary>
/// Abstract class for Arses (genus).
/// NCBI TaxId: 338443
/// </summary>
public abstract class Arses : Monarchidae, IArses
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arses";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 338443;

    /// <inheritdoc />
    public virtual string GenusName => "Arses";

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
