using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Foudia;

/// <summary>
/// Abstract class for Foudia (genus).
/// NCBI TaxId: 441682
/// </summary>
public abstract class Foudia : Ploceidae, IFoudia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Foudia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 441682;

    /// <inheritdoc />
    public virtual string GenusName => "Foudia";

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
