using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Pampa;

/// <summary>
/// Abstract class for Pampa (genus).
/// NCBI TaxId: 3162949
/// </summary>
public abstract class Pampa : Trochilidae, IPampa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pampa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3162949;

    /// <inheritdoc />
    public virtual string GenusName => "Pampa";

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
