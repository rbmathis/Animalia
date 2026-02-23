using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Aphelocephala;

/// <summary>
/// Abstract class for Aphelocephala (genus).
/// NCBI TaxId: 117200
/// </summary>
public abstract class Aphelocephala : Acanthizidae, IAphelocephala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphelocephala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117200;

    /// <inheritdoc />
    public virtual string GenusName => "Aphelocephala";

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
