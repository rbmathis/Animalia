using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Conopophagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Conopophagidae.Conopophaga;

/// <summary>
/// Abstract class for Conopophaga (genus).
/// NCBI TaxId: 123373
/// </summary>
public abstract class Conopophaga : Conopophagidae, IConopophaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conopophaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123373;

    /// <inheritdoc />
    public virtual string GenusName => "Conopophaga";

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
