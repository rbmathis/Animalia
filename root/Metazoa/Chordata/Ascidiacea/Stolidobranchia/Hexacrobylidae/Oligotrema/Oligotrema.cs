using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Hexacrobylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Hexacrobylidae.Oligotrema;

/// <summary>
/// Abstract class for Oligotrema (genus).
/// NCBI TaxId: 1097432
/// </summary>
public abstract class Oligotrema : Hexacrobylidae, IOligotrema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oligotrema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1097432;

    /// <inheritdoc />
    public virtual string GenusName => "Oligotrema";

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
