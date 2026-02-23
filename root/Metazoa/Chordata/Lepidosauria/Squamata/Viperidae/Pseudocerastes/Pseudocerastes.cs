using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Pseudocerastes;

/// <summary>
/// Abstract class for Pseudocerastes (genus).
/// NCBI TaxId: 47768
/// </summary>
public abstract class Pseudocerastes : Viperidae, IPseudocerastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocerastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47768;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocerastes";

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
