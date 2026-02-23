using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae.Scenopoeetes;

/// <summary>
/// Abstract class for Scenopoeetes (genus).
/// NCBI TaxId: 1131247
/// </summary>
public abstract class Scenopoeetes : Ptilonorhynchidae, IScenopoeetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scenopoeetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1131247;

    /// <inheritdoc />
    public virtual string GenusName => "Scenopoeetes";

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
