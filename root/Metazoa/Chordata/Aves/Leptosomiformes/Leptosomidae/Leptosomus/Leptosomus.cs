using AnimalKingdom.root.Metazoa.Chordata.Aves.Leptosomiformes.Leptosomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Leptosomiformes.Leptosomidae.Leptosomus;

/// <summary>
/// Abstract class for Leptosomus (genus).
/// NCBI TaxId: 188343
/// </summary>
public abstract class Leptosomus : Leptosomidae, ILeptosomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptosomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188343;

    /// <inheritdoc />
    public virtual string GenusName => "Leptosomus";

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
