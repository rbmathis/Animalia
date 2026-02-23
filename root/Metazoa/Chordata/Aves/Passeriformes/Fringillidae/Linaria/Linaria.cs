using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Linaria;

/// <summary>
/// Abstract class for Linaria (genus).
/// NCBI TaxId: 1930290
/// </summary>
public abstract class Linaria : Fringillidae, ILinaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Linaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1930290;

    /// <inheritdoc />
    public virtual string GenusName => "Linaria";

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
