using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Gracula;

/// <summary>
/// Abstract class for Gracula (genus).
/// NCBI TaxId: 116991
/// </summary>
public abstract class Gracula : Sturnidae, IGracula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gracula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 116991;

    /// <inheritdoc />
    public virtual string GenusName => "Gracula";

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
