using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Callacanthis;

/// <summary>
/// Abstract class for Callacanthis (genus).
/// NCBI TaxId: 1105350
/// </summary>
public abstract class Callacanthis : Fringillidae, ICallacanthis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callacanthis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1105350;

    /// <inheritdoc />
    public virtual string GenusName => "Callacanthis";

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
