using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Scepomycter;

/// <summary>
/// Abstract class for Scepomycter (genus).
/// NCBI TaxId: 759712
/// </summary>
public abstract class Scepomycter : Cisticolidae, IScepomycter
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scepomycter";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 759712;

    /// <inheritdoc />
    public virtual string GenusName => "Scepomycter";

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
