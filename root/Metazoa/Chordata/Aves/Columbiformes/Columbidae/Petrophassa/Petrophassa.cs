using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Petrophassa;

/// <summary>
/// Abstract class for Petrophassa (genus).
/// NCBI TaxId: 262133
/// </summary>
public abstract class Petrophassa : Columbidae, IPetrophassa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petrophassa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 262133;

    /// <inheritdoc />
    public virtual string GenusName => "Petrophassa";

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
