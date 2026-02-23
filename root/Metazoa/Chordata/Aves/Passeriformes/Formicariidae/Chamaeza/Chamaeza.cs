using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Chamaeza;

/// <summary>
/// Abstract class for Chamaeza (genus).
/// NCBI TaxId: 183182
/// </summary>
public abstract class Chamaeza : Formicariidae, IChamaeza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chamaeza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183182;

    /// <inheritdoc />
    public virtual string GenusName => "Chamaeza";

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
