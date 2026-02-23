using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Ampeliceps;

/// <summary>
/// Abstract class for Ampeliceps (genus).
/// NCBI TaxId: 245043
/// </summary>
public abstract class Ampeliceps : Sturnidae, IAmpeliceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ampeliceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245043;

    /// <inheritdoc />
    public virtual string GenusName => "Ampeliceps";

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
