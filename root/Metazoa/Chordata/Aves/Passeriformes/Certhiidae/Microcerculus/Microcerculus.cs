using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Microcerculus;

/// <summary>
/// Abstract class for Microcerculus (genus).
/// NCBI TaxId: 241543
/// </summary>
public abstract class Microcerculus : Certhiidae, IMicrocerculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microcerculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241543;

    /// <inheritdoc />
    public virtual string GenusName => "Microcerculus";

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
