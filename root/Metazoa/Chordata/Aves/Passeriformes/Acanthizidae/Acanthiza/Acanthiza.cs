using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Acanthiza;

/// <summary>
/// Abstract class for Acanthiza (genus).
/// NCBI TaxId: 108820
/// </summary>
public abstract class Acanthiza : Acanthizidae, IAcanthiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108820;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthiza";

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
