using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae.Ailuroedus;

/// <summary>
/// Abstract class for Ailuroedus (genus).
/// NCBI TaxId: 28721
/// </summary>
public abstract class Ailuroedus : Ptilonorhynchidae, IAiluroedus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ailuroedus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28721;

    /// <inheritdoc />
    public virtual string GenusName => "Ailuroedus";

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
