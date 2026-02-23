using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Fregilupus;

/// <summary>
/// Abstract class for Fregilupus (genus).
/// NCBI TaxId: 531868
/// </summary>
public abstract class Fregilupus : Sturnidae, IFregilupus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fregilupus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 531868;

    /// <inheritdoc />
    public virtual string GenusName => "Fregilupus";

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
