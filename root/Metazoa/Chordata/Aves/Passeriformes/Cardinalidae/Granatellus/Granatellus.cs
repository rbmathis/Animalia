using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Granatellus;

/// <summary>
/// Abstract class for Granatellus (genus).
/// NCBI TaxId: 182928
/// </summary>
public abstract class Granatellus : Cardinalidae, IGranatellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Granatellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182928;

    /// <inheritdoc />
    public virtual string GenusName => "Granatellus";

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
