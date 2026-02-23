using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Chrysocorythus;

/// <summary>
/// Abstract class for Chrysocorythus (genus).
/// NCBI TaxId: 3150788
/// </summary>
public abstract class Chrysocorythus : Fringillidae, IChrysocorythus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysocorythus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150788;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysocorythus";

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
