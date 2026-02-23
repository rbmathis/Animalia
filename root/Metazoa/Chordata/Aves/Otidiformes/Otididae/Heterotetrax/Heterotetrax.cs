using AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Heterotetrax;

/// <summary>
/// Abstract class for Heterotetrax (genus).
/// NCBI TaxId: 3150807
/// </summary>
public abstract class Heterotetrax : Otididae, IHeterotetrax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterotetrax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150807;

    /// <inheritdoc />
    public virtual string GenusName => "Heterotetrax";

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
