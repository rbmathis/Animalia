using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Plectrophenax;

/// <summary>
/// Abstract class for Plectrophenax (genus).
/// NCBI TaxId: 161626
/// </summary>
public abstract class Plectrophenax : Fringillidae, IPlectrophenax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plectrophenax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161626;

    /// <inheritdoc />
    public virtual string GenusName => "Plectrophenax";

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
