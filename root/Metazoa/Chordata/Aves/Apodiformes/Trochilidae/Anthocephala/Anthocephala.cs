using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Anthocephala;

/// <summary>
/// Abstract class for Anthocephala (genus).
/// NCBI TaxId: 689202
/// </summary>
public abstract class Anthocephala : Trochilidae, IAnthocephala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anthocephala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 689202;

    /// <inheritdoc />
    public virtual string GenusName => "Anthocephala";

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
