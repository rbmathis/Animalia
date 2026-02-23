using AnimalKingdom.root.Metazoa.Chordata.Aves.Opisthocomiformes.Opisthocomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Opisthocomiformes.Opisthocomidae.Opisthocomus;

/// <summary>
/// Abstract class for Opisthocomus (genus).
/// NCBI TaxId: 30418
/// </summary>
public abstract class Opisthocomus : Opisthocomidae, IOpisthocomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opisthocomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30418;

    /// <inheritdoc />
    public virtual string GenusName => "Opisthocomus";

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
