using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae.Archboldia;

/// <summary>
/// Abstract class for Archboldia (genus).
/// NCBI TaxId: 34938
/// </summary>
public abstract class Archboldia : Ptilonorhynchidae, IArchboldia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Archboldia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34938;

    /// <inheritdoc />
    public virtual string GenusName => "Archboldia";

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
