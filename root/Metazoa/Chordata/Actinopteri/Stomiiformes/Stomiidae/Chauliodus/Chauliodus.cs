using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Chauliodus;

/// <summary>
/// Abstract class for Chauliodus (genus).
/// NCBI TaxId: 68508
/// </summary>
public abstract class Chauliodus : Stomiidae, IChauliodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chauliodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68508;

    /// <inheritdoc />
    public virtual string GenusName => "Chauliodus";

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
