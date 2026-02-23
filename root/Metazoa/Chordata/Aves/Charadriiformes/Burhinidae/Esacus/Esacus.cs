using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Burhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Burhinidae.Esacus;

/// <summary>
/// Abstract class for Esacus (genus).
/// NCBI TaxId: 2577025
/// </summary>
public abstract class Esacus : Burhinidae, IEsacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Esacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2577025;

    /// <inheritdoc />
    public virtual string GenusName => "Esacus";

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
