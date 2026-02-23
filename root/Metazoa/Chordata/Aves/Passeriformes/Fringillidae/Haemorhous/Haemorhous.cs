using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Haemorhous;

/// <summary>
/// Abstract class for Haemorhous (genus).
/// NCBI TaxId: 1523891
/// </summary>
public abstract class Haemorhous : Fringillidae, IHaemorhous
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haemorhous";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1523891;

    /// <inheritdoc />
    public virtual string GenusName => "Haemorhous";

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
