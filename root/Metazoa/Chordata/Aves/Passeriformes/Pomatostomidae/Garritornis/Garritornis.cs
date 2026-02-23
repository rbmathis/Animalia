using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pomatostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pomatostomidae.Garritornis;

/// <summary>
/// Abstract class for Garritornis (genus).
/// NCBI TaxId: 2821481
/// </summary>
public abstract class Garritornis : Pomatostomidae, IGarritornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Garritornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821481;

    /// <inheritdoc />
    public virtual string GenusName => "Garritornis";

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
