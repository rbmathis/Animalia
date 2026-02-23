using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Acanthis;

/// <summary>
/// Abstract class for Acanthis (genus).
/// NCBI TaxId: 37604
/// </summary>
public abstract class Acanthis : Fringillidae, IAcanthis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37604;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthis";

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
