using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Pygiptila;

/// <summary>
/// Abstract class for Pygiptila (genus).
/// NCBI TaxId: 288061
/// </summary>
public abstract class Pygiptila : Thamnophilidae, IPygiptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pygiptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288061;

    /// <inheritdoc />
    public virtual string GenusName => "Pygiptila";

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
