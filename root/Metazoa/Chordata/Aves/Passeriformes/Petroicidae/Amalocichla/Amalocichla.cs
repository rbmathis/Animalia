using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Amalocichla;

/// <summary>
/// Abstract class for Amalocichla (genus).
/// NCBI TaxId: 692105
/// </summary>
public abstract class Amalocichla : Petroicidae, IAmalocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amalocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 692105;

    /// <inheritdoc />
    public virtual string GenusName => "Amalocichla";

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
