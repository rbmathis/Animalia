using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae.Chlamydochaera;

/// <summary>
/// Abstract class for Chlamydochaera (genus).
/// NCBI TaxId: 311361
/// </summary>
public abstract class Chlamydochaera : Ptilonorhynchidae, IChlamydochaera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlamydochaera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 311361;

    /// <inheritdoc />
    public virtual string GenusName => "Chlamydochaera";

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
