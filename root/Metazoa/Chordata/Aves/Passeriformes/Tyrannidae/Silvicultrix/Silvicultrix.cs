using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Silvicultrix;

/// <summary>
/// Abstract class for Silvicultrix (genus).
/// NCBI TaxId: 1604844
/// </summary>
public abstract class Silvicultrix : Tyrannidae, ISilvicultrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Silvicultrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1604844;

    /// <inheritdoc />
    public virtual string GenusName => "Silvicultrix";

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
