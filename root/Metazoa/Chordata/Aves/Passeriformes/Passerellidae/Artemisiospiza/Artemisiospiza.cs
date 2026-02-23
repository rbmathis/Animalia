using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Artemisiospiza;

/// <summary>
/// Abstract class for Artemisiospiza (genus).
/// NCBI TaxId: 2502001
/// </summary>
public abstract class Artemisiospiza : Passerellidae, IArtemisiospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Artemisiospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2502001;

    /// <inheritdoc />
    public virtual string GenusName => "Artemisiospiza";

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
