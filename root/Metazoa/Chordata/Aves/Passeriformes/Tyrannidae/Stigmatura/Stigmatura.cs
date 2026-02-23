using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Stigmatura;

/// <summary>
/// Abstract class for Stigmatura (genus).
/// NCBI TaxId: 83303
/// </summary>
public abstract class Stigmatura : Tyrannidae, IStigmatura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stigmatura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83303;

    /// <inheritdoc />
    public virtual string GenusName => "Stigmatura";

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
