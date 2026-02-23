using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Pelecanoides;

/// <summary>
/// Abstract class for Pelecanoides (genus).
/// NCBI TaxId: 37077
/// </summary>
public abstract class Pelecanoides : Procellariidae, IPelecanoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelecanoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37077;

    /// <inheritdoc />
    public virtual string GenusName => "Pelecanoides";

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
